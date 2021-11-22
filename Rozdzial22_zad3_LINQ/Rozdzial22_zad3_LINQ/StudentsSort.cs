using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozdzial22_zad3_LINQ
{
    class StudentsSort
    {
        public static IEnumerable<Student> GetSortedStudentsCollectionLinq(IEnumerable<Student> sourceCollection, bool useParallel = false)
        {
            if (useParallel)
            {
                sourceCollection = sourceCollection.AsParallel();
            }

            var sortedStudentsCollection = from student in sourceCollection
                                           orderby student.FirstName descending, student.LastName descending
                                           select student;
            return sortedStudentsCollection;
        }

        public static IEnumerable<Student> GetSortedStudentsCollection(IEnumerable<Student> sourceCollection, bool useParallel = false)
        {
            if (useParallel)
            {
                sourceCollection = sourceCollection.AsParallel();
            }

            IEnumerable<Student> sortedStudentsCollection = sourceCollection.OrderByDescending(s => s.FirstName).ThenByDescending(s => s.LastName);
            return sortedStudentsCollection;
        }
    }

}
