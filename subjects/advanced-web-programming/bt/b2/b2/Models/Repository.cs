using System.Collections.Generic;
using System.Linq;

namespace b2.Models
{
    public static class Repository
    {
        private static List<GuestResponse> responses = new List<GuestResponse>();

        public static IEnumerable<GuestResponse> Responses
        {
            get { return responses; }
        }

        public static void AddResponse(GuestResponse response)
        {
            responses.Add(response);
        }

        public static IEnumerable<GuestResponse> GetAttendees()
        {
            return responses.Where(r => r.WillAttend == true);
        }

        public static IEnumerable<GuestResponse> GetAttendeesByCourse(string course)
        {
            if (string.IsNullOrEmpty(course))
                return GetAttendees();

            return responses.Where(r => r.WillAttend == true && r.Course == course);
        }

        public static IEnumerable<string> GetUniqueCourses()
        {
            return responses.Where(r => r.WillAttend == true)
                          .Select(r => r.Course)
                          .Distinct()
                          .OrderBy(c => c);
        }
    }
}