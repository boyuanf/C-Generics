using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectIt
{
    public class EmployeeComparer : IEqualityComparer<Employee>, IComparer<Employee>
    {
        public bool Equals(Employee x, Employee y)
        {
            return String.Equals(x.Name, y.Name);
        }

        public int GetHashCode(Employee obj)
        {
            return obj.Name.GetHashCode();
        }

        public int Compare(Employee x, Employee y)
        {
            return String.CompareOrdinal(x.Name, y.Name);
        }
    }

    public class DepartmentCollection :
        SortedDictionary<string, SortedSet<Employee>>
    {
        public DepartmentCollection Add(String departmentName, Employee employee)
        {
            if (!ContainsKey(departmentName))
            {
                Add(departmentName, new SortedSet<Employee>(new EmployeeComparer()));
            }
            this[departmentName].Add(employee);
            return this;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //LearnList();
            //LearnQueue();
            //LearnStack();
            //LearnHashSet();
            //Dictionary<string, Employee> employeesByName = new Dictionary<string, Employee>();

            var departments = new DepartmentCollection();

            departments.Add("Engineering",
                new SortedSet<Employee>(new EmployeeComparer())
                {
                    new Employee(){Name = "scott"},
                    new Employee(){Name = "Alex"}
                });
            departments["Engineering"].Add(new Employee() { Name = "Alex" });

            departments.Add("Sales", new SortedSet<Employee>(new EmployeeComparer()));
            departments["Sales"].Add(new Employee() { Name = "Leet" });
            departments["Sales"].Add(new Employee() { Name = "Fance" });
            departments["Sales"].Add(new Employee() { Name = "Mary" });

            foreach (var item in departments)
            {
                Console.WriteLine("Department name: {0}", item.Key);
                foreach (var employee in item.Value)
                {
                    Console.WriteLine("\t" + employee.Name);
                }
            }

        }

        private static void DictionaryContainHashSet()
        {
            var departments = new SortedDictionary<string, HashSet<Employee>>();

            departments.Add("Engineering",
                new HashSet<Employee>(new EmployeeComparer())
                {
                    new Employee(){Name = "scott"},
                    new Employee(){Name = "Alex"}
                });
            departments["Engineering"].Add(new Employee() { Name = "Alex" });

            departments.Add("Sales", new HashSet<Employee>(new EmployeeComparer()));
            departments["Sales"].Add(new Employee() { Name = "Leet" });
            departments["Sales"].Add(new Employee() { Name = "Fance" });
            departments["Sales"].Add(new Employee() { Name = "Mary" });

            foreach (var item in departments)
            {
                Console.WriteLine("Department name: {0}", item.Key);
                foreach (var employee in item.Value)
                {
                    Console.WriteLine("\t" + employee.Name);
                }
            }
        }


        private static void LearnDictionary()
        {
            var employeesByName = new Dictionary<string, Employee>();

            employeesByName.Add("Scott", new Employee() { Name = "scott" });
            employeesByName.Add("Alex", new Employee { Name = "alex" });
            employeesByName.Add("Joy", new Employee { Name = "joy" });

            var scott = employeesByName["Scott"];

            Console.WriteLine(scott.Name);

            foreach (var item in employeesByName)
            {
                Console.WriteLine("{0}:{1}", item.Key, item.Value.Name);
            }


            var departments = new Dictionary<string, List<Employee>>();
            departments.Add("Engineering",
                new List<Employee>()
                {
                    new Employee(){Name = "scott"},
                    new Employee(){Name = "Alex"}
                });
            departments["Engineering"].Add(new Employee() { Name = "Joe" });

            departments.Add("Sales", new List<Employee>());
            departments["Sales"].Add(new Employee() { Name = "Leet" });
            departments["Sales"].Add(new Employee() { Name = "Fance" });
            departments["Sales"].Add(new Employee() { Name = "Mary" });

            foreach (var item in departments)
            {
                Console.WriteLine("Department name: {0}", item.Key);
                foreach (var employee in item.Value)
                {
                    Console.WriteLine("\t" + employee.Name);
                }
            }
        }

        private static void LearnHashSet()
        {
            HashSet<Employee> set = new HashSet<Employee>() //don't allow duplicated elements in the set
            {
                new Employee() {Name = "Scoot"},
                new Employee() {Name = "Scoot2"}
            };

            set.Add(new Employee() {Name = "Scoot2"}); //different object reference, although they have the same Name property

            var employee = new Employee() {Name = "Scoot"};
            set.Add(employee); //same object reference
            set.Add(employee);

            foreach (var item in set)
            {
                Console.WriteLine(item.Name);
            }
        }

        private static void LearnStack()
        {
            Stack<Employee> stack = new Stack<Employee>();
            stack.Push(new Employee() {Name = "Alex"});
            stack.Push(new Employee() {Name = "Dani"});
            stack.Push(new Employee() {Name = "Chris"});

            while (stack.Count > 0)
            {
                var employee = stack.Pop();
                Console.WriteLine(employee.Name);
            }
        }

        private static void LearnList()
        {
            List<int> alist = new List<int>() {1, 3, 2};
            //Array
            Employee testEmployee = new Employee();
            Employee testEmployee3 = new Employee {Name = "Scoot"};

            int[] a = new int[5];

            Employee[] employees = new Employee[]
            {
                new Employee {Name = "Scoot"},
                new Employee {Name = "Alex"}
            };

            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Name);
            }
            //List

            List<Employee> employeeslist = new List<Employee>
            {
                new Employee {Name = "Scottlist"},
                new Employee {Name = "Alexlist"}
            };
            employeeslist.Add(new Employee() {Name = "Danilist"});
            foreach (var employee in employeeslist)
            {
                Console.WriteLine(employee.Name);
            }

            //test capacity
            //the last parameter present the initial capacity, which will increase after we insert element into the list
            var numbers = new List<int>(10);
            var capacity = -1;

            while (true)
            {
                if (numbers.Capacity != capacity)
                {
                    capacity = numbers.Capacity;
                    Console.WriteLine(capacity);
                }
                numbers.Add(1);
            }
        }

        private static void LearnQueue()
        {
            Queue<Employee> queue = new Queue<Employee>();
            queue.Enqueue(new Employee() {Name = "Alex"});
            queue.Enqueue(new Employee() {Name = "Dani"});
            queue.Enqueue(new Employee() {Name = "Chris"});

            while (queue.Count > 0)
            {
                var employee = queue.Dequeue();
                Console.WriteLine(employee.Name);
            }
        }
    }
}
