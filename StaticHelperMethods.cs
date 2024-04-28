namespace Helpers {
    public static class StaticHelperMethods {
        private static List<int> _numbers = new() {1, 2, 3, 4, 5};

        public static void PrintSomeNumbers() {
            foreach (var num in _numbers) {
                Console.WriteLine(num);
            }
        }
    }
}