using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.VisualBasic.FileIO;
using MovieMauiAPI.Models;
using Newtonsoft.Json;

namespace FilmFinderApi.Data
{
    public class SeedDataMovieData : IEntityTypeConfiguration<MovieCatalogModel>
    {
        public void Configure(EntityTypeBuilder<MovieCatalogModel> builder)
        {
            
            builder.HasData(Load_Data());
        }
        public List<MovieCatalogModel> Load_Data()
        {
            var movieList = new List<MovieCatalogModel>();
            var filepath = "/Users/royclaudio/Desktop/FilmFinder/FilmFinderAI/FilmFinderApi/Data/MovieList1000.csv";
            string jsonString = ReadCSVFile(filepath);
            //movieList = (JsonConvert.SerializeObject <(List<MovieCatalogModel>)> (jsonString));
            List<MovieCatalogModel> movies = JsonConvert.DeserializeObject<List<MovieCatalogModel>>(jsonString);

           

            return movies;

        }
        private static string ReadCSVFile(string csv_file_path)
        {
            DataTable csvData = new DataTable();
            string jsonString = string.Empty;
            try
            {
                using (TextFieldParser csvReader = new TextFieldParser(csv_file_path))
                {
                    csvReader.SetDelimiters(new string[] { "," });
                    csvReader.HasFieldsEnclosedInQuotes = true;
                    string[] colFields;
                    bool tableCreated = false;
                    while (tableCreated == false)
                    {
                        colFields = csvReader.ReadFields();
                        foreach (string column in colFields)
                        {
                            DataColumn datecolumn = new DataColumn(column);
                            datecolumn.AllowDBNull = true;
                            csvData.Columns.Add(datecolumn);
                        }
                        tableCreated = true;
                    }
                    while (!csvReader.EndOfData)
                    {
                        csvData.Rows.Add(csvReader.ReadFields());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "Error:Parsing CSV";
            }
            //if everything goes well, serialize csv to json 
            jsonString = JsonConvert.SerializeObject(csvData);

            return jsonString;
        }
    }
}