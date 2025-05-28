using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace NotesApp
{
    class Notes
    {
        public static List<Note> GetNotes()
        {
            List<Note> notes = new List<Note>();
            string query = "SELECT * FROM Notes ORDER BY Name";

            using (SqlConnection sqlConnection = new SqlConnection(Baza.KonekcijskiString()))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                foreach (DataRow redak in ds.Tables[0].Rows)
                {
                    notes.Add(new Note(
                        redak["Id"],
                        redak["Content"],
                        redak["Name"]
                    ));
                }
            }
            return notes;
        }

        public static bool AddNote(Note note)
        {
            string query = "INSERT INTO Notes (Content, Name) VALUES (@Content, @Name)";

            using (SqlConnection sqlConnection = new SqlConnection(Baza.KonekcijskiString()))
            {
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@Content", note.Content);
                    command.Parameters.AddWithValue("@Name", note.Name);

                    sqlConnection.Open();
                    int result = command.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }

        public static Note GetNote(int id)
        {
            Note note = null;
            string query = "SELECT * FROM Notes WHERE Id = @Id";

            using (SqlConnection conn = new SqlConnection(Baza.KonekcijskiString()))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    note = new Note(
                        reader["Id"],
                        reader["Content"],
                        reader["Name"]
                    );
                }
            }
            return note;
        }

        public static bool UpdateNote(Note note, string newContent)
        {
            string query = "UPDATE Notes SET Content = @Content WHERE Id = @Id";

            using (SqlConnection conn = new SqlConnection(Baza.KonekcijskiString()))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Content", newContent);
                cmd.Parameters.AddWithValue("@Id", note.Id);
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

        public static bool DeleteNote(int id)
        {
            string query = "DELETE FROM Notes WHERE Id = @Id";

            using (SqlConnection conn = new SqlConnection(Baza.KonekcijskiString()))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }
    }
}
