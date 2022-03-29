namespace HW_2
{
    internal static class Run_IEnumerable
    {
        public static void Main()
        {
            List<Entity> essence = new List<Entity>()
            {
                new Entity {Id = 1, ParentId = 0, Name = "Root entity"},
                new Entity {Id = 2, ParentId = 1, Name = "Child of 1 entity"},
                new Entity {Id = 3, ParentId = 1, Name = "Child of 1 entity"},
                new Entity {Id = 4, ParentId = 2, Name = "Child of 2 entity"},
                new Entity {Id = 5, ParentId = 4, Name = "Child of 4 entity"}
            };

            var essence_dic = essence.GroupBy(l => l.ParentId)
                .ToDictionary(gdc => gdc.Key, gdc => gdc.ToList());

            foreach (var elem in essence_dic)
            {
                Console.Write($"key: {elem.Key}");
                foreach (var elem2 in elem.Value)
                {
                    Console.Write($" id =  {elem2.Id} ");
                }

                Console.WriteLine();
            }

        }
    }
}