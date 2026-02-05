using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;

namespace NomenklatorApp
{
    public class TestService
    {
        public List<string> UserAnswers { get; set; } = new();
        public int Score { get; set; }

        private readonly HttpClient _http;
        public List<ElementData> AllElements { get; private set; } = new();
        public List<ElementData> CurrentTestQuestions { get; set; } = new();

        public TestService(HttpClient http)
        {
            _http = http;
        }

        public async Task LoadElementsAsync()
        {
            try
            {
                var data = await _http.GetFromJsonAsync<List<ElementData>>("/data/elements.json");
                if (data != null)
                {
                    AllElements = data;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"SERVICE CRITICAL ERROR: {ex.Message}");
                AllElements = new List<ElementData>(); 
            }
        }

        private readonly Random _random = new();

        public void GenerateNewTest(int numberOfQuestions)
        {
            if (!AllElements.Any()) return;

            Score = 0;
            UserAnswers.Clear();

            CurrentTestQuestions = AllElements
                .OrderBy(x => _random.Next())
                .Take(numberOfQuestions)
                .ToList();

        }
    }

    public class ElementData
    {
        public string Key { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
    }
}
