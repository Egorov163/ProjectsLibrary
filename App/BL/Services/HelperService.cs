namespace App.BL.Services
{
    public static class HelperService
    {
        /// <summary>
        /// Запрашивает ответ у пользователя и проверяет на корректность, ответ должен быть int.
        /// </summary>
        /// <param name="RequestText">Текст к запросу.</param>
        /// <returns>int, если -1, то пользователь отказался вводить запрос.</returns>
        public static int RequestIntInput(string RequestText = "")
        {
            Console.WriteLine(RequestText);
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
                    return -1;
                }

                Console.WriteLine("Некорректный запрос, попробуй ещё раз, если хотите выйти введите q!");
            }
        }
    }
}
