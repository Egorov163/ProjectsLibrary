using System.Globalization;

namespace App.BL.Services
{
    public static class HelperService
    {
        /// <summary>
        /// Запрашивает ответ у пользователя и проверяет на корректность, ответ должен быть int.
        /// </summary>
        /// <param name="RequestText">Текст к запросу.</param>
        /// <returns>int, если -1, то пользователь отказался вводить запрос.</returns>
        public static int? RequestIntInput(string requestText = "")
        {
            Console.WriteLine(requestText);
            string request;

            while (true)
            {
                request = Console.ReadLine();

                if (int.TryParse(request, out int result))
                {
                    return result;
                }
                else if (request == "q!")
                {
                    return null;
                }

                Console.WriteLine("Некорректный запрос, попробуй ещё раз, если хотите выйти введите q!");
            }
        }

        /// <summary>
        /// Запрашивает ответ у пользователя и проверяет на корректность, ответ должен быть строкой.
        /// </summary>
        /// <param name="RequestText">Текст к запросу.</param>
        /// <returns>Ответ пользователя или null, если null, то пользователь отказался вводить запрос.</returns>
        public static string? RequestStringInput(string requestText = "")
        {
            Console.WriteLine(requestText);
            string request;

            while (true)
            {
                request = Console.ReadLine();
                var stopWord = "q!";

                if (request == stopWord)
                {
                    return null;
                }
                else if (!string.IsNullOrWhiteSpace(request))
                {
                    
                    return request;
                }

                Console.WriteLine("Некорректный запрос, попробуй ещё раз, если хотите выйти введите q!");
            }
        }

        /// <summary>
        /// Запрашивает ответ у пользователя и проверяет на корректность, ответ должен быть int.
        /// </summary>
        /// <typeparam name="T">Тип Enum</typeparam>
        /// <param name="requestText">Текст к запросу.</param>
        /// <param name="writeEmunValue">Нужно ли выводить список Enum</param>
        /// <returns>Ответ пользователя или null, если null, то пользователь отказался вводить запрос.</returns>
        public static int? RequestEnumInput<T>(string requestText = "", bool writeEmunValue = true)
            where T : Enum
        {
            Console.WriteLine(requestText);

            var enumList = Enum.GetValues(typeof(T));
            var countEnum = enumList.Length;

            if (writeEmunValue)
            {
                for (int i = 0; i < countEnum; i++)
                {
                    Console.WriteLine($"{enumList.GetValue(i)} - {i}");
                }
            }

            while (true)
            {
                var request = RequestIntInput();

                if (request is null)
                {
                    return null;
                }
                else if(request > 0 && (countEnum - 1) >= request)
                {
                    return request;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод, попробуйте ещё раз");
                }
            }
        }

        /// <summary>
        /// Запрашивает ответ у пользователя и проверяет на корректность, ответ должен быть dateTime.
        /// </summary>
        /// <param name="requestText">Текст к запросу.</param>
        /// <returns>Ответ пользователя или null, если null, то пользователь отказался вводить запрос.</returns>
        public static DateTimeOffset? RequestDateTimeInput(string requestText = "")
        {
            Console.WriteLine(requestText);

            while (true)
            {
                var requestStr = RequestStringInput();

                if (DateTimeOffset.TryParseExact(requestStr, "dd.MM.yyyy",
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTimeOffset result))
                {
                    return result;
                }
                else if (requestStr is null)
                {
                    return null;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод, попробуйте ещё раз");
                }
            }
        }
    }
}
