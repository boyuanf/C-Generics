using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectIt
{
    class Program
    {
        static void Main(string[] args)
        {
            //LearnList();
            //LearnQueue();
            //LearnStack();
            //LearnHashSet();
            //Dictionary<string, Employee> employeesByName = new Dictionary<string, Employee>();
            var employeesByName = new Dictionary<string, Employee>();

            employeesByName.Add("Scott", new Employee() { Name = "scott" });
            employeesByName.Add("Alex", new Employee { Name = "alex" });
            employeesByName.Add("Joy", new Employee { Name = "joy" });

            var scott = employeesByName["Scott"];

            Console.WriteLine(scott.Name);

            foreach (var item in employeesByName)
            {
                Console.WriteLine("{0}:{1}",item.Key,item.Value.Name);
            }

            var employeesByDepartment=new Dictionary<string,List<Employee>>();
            employeesByDepartment.Add("Engineering",
                new List<Employee>()
                {
                    new Employee(){Name = "scott"},
                    new Employee(){Name = "Alex"}
                });
            employeesByDepartment["Engineering"].Add(new Employee(){Name = "Joe"});

            foreach (var item in employeesByDepartment)
            {
                Console.WriteLine("Department name: {0}",item.Key);
                foreach (var employee in item.Value)
                {
                    Console.WriteLine(employee.Name);
                }
            }

            var employeesByNameSort = new SortedDictionary<string,List<Employee>>();

            employeesByNameSort.Add("Sales", new List<Employee>() { new Employee(), new Employee(), new Employee() });
            employeesByNameSort.Add("Engineer", new List<Employee>() { new Employee(), new Employee() });

            foreach (var item in employeesByNameSort)
            {
                Console.WriteLine("count of employees for {0} is {1}", item.Key,item.Value.Count);
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
