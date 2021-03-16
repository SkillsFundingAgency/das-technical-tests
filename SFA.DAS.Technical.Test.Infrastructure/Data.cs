using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SFA.DAS.Technical.Test.Infrastructure
{
    public class Data
    {
        private const string DATAFILE = "input.data";
        private readonly Random _random;

        private readonly int interations = 500;
        public Data()
        {
            _random = new Random();
        }

        private bool DataFileExists() =>  File.Exists(DATAFILE);

        private IEnumerable<int> Split(string data) => data.Split("\n").Where(c => !string.IsNullOrEmpty(c)).Select(c => int.Parse(c));

        private async Task WriteLine(StreamWriter stream) => await stream.WriteLineAsync(_random.Next(1, 1000).ToString());

        public async Task<IEnumerable<int>> Generate()
        {
            if(!DataFileExists())
            {
                using var stream = File.CreateText(DATAFILE);

                var i = 0;
                while((i++) < interations) await WriteLine(stream);
            }

            return Split(await File.ReadAllTextAsync(DATAFILE));
        }
    }
}