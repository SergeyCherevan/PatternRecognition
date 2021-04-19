using Newtonsoft.Json;
using PatternRecognition.RecognitionOptionsNamespace;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatternRecognition
{
    public class ComputationOfSymbolRecognition
    {
        public int H, W;

        public LinkedList<(double[,], string)> mapOfSymbols = new LinkedList<(double[,], string)>();

        public void SetMapToFile(string path)
        {
            StreamWriter file = new StreamWriter(path, false);

            var jsonSerializer = new Newtonsoft.Json.JsonSerializer();
            jsonSerializer.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            jsonSerializer.TypeNameHandling = TypeNameHandling.Auto;
            jsonSerializer.Formatting = Formatting.Indented;

            JsonWriter jsonWriter = new JsonTextWriter(file);

            jsonSerializer.Serialize(jsonWriter, this);

            jsonWriter.Close();
            file.Close();
        }

        public void GetMapFromFile(string path)
        {
            StreamReader file = new StreamReader(path, false);

            var jsonSerializer = new JsonSerializer();
            jsonSerializer.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            jsonSerializer.TypeNameHandling = TypeNameHandling.Auto;
            jsonSerializer.Formatting = Formatting.Indented;

            JsonReader jsonReader = new JsonTextReader(file);

            ComputationOfSymbolRecognition csr = jsonSerializer.Deserialize<ComputationOfSymbolRecognition>(jsonReader);

            H = csr.H;
            W = csr.W;
            mapOfSymbols = csr.mapOfSymbols;

            jsonReader.Close();
            file.Close();
        }

        public void GetMapFromImagesBank(string path, int h, int w)
        {
            string[] files = Directory.GetFiles(path, "*.jpg");

            H = h; W = w;


            foreach (string fileName in files)
            {
                Image image = Image.FromFile(fileName);

                RecognitionOptions ro = new OptionsOfBicolorRecognition();

                var Mprc = new ManagerOfPatternRecognComputation { ImageIn = image, RO = ro };

                Mprc.Computate();

                Symbol symbol = new Symbol((Figure<bool>)Mprc.PatternRecognResult.figureList.Last.Value);

                mapOfSymbols.AddLast(( symbol.GetAreas(), fileName.Substring(fileName.LastIndexOf("\\") + 1).Replace(".jpg", "") ));
            }

            /*MessageBox.Show(JsonConvert.SerializeObject(
                    this,
                    Formatting.Indented,
                    new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto }
                ),
                "Результаты обучения"
                );*/
        }
    }
}
