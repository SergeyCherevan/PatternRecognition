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
        public bool isValid = false;

        public int H, W;

        public LinkedList<(double[,], string)> mapOfSymbols = new LinkedList<(double[,], string)>();

        public void SetMapToJson(string path)
        {
            if (!isValid)
                throw new ArgumentException("Объект класса ComputationOfSymbolRecognition не был инициализирован перед записью в файл.");

            StreamWriter file = new StreamWriter(path, false);

            var jsonSerializer = new JsonSerializer();
            jsonSerializer.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            jsonSerializer.TypeNameHandling = TypeNameHandling.Auto;
            jsonSerializer.Formatting = Formatting.Indented;

            JsonWriter jsonWriter = new JsonTextWriter(file);

            jsonSerializer.Serialize(jsonWriter, this);

            jsonWriter.Close();
            file.Close();

            MessageBox.Show("Запись днных в JSON произведена!", "Сообщение");
        }

        public void GetMapFromJson(string path)
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

            isValid = true;

            MessageBox.Show("Считывание днных из JSON произведено!", "Сообщение");
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

            isValid = true;

            MessageBox.Show("Обучение успешно пройдено!", "Сообщение");
        }

        public string RecogniteSymbol(Symbol symbol)
        {
            if (!isValid)
                throw new ArgumentException("Объект класса ComputationOfSymbolRecognition не был инициализирован перед записью в файл.");

            double[,] symbolAreas = symbol.GetAreas();

            double minDif = Double.MaxValue;
            string nearestSymb = null;

            foreach (var (curAreas, curSymb) in mapOfSymbols)
            {
                double dif = 0;

                for (int y = 0; y < curAreas.GetLength(0); y++)
                {
                    for (int x = 0; x < curAreas.GetLength(1); x++)
                    {
                        dif += Math.Pow(curAreas[y, x] - symbolAreas[y, x], 2);
                    }
                }

                dif = Math.Sqrt(dif);

                if(minDif > dif)
                {
                    minDif = dif;

                    nearestSymb = curSymb;
                }
            }

            return nearestSymb;
        }
    }
}
