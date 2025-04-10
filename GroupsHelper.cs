using System.Collections.Generic;

namespace Week5Lesson27
{
    internal class GroupsHelper
    {
        public static List<Group> GetGroups()
        {
            return new List<Group>
            {
                new Group { Id = 0, Name = "Wszyscy" },
                new Group { Id = 1, Name = "Zatrudnieni" },
                new Group { Id = 2, Name = "Zwolnieni" },                
            };
        }

    }
}
