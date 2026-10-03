using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics;
public class StudentStore
{
    private readonly List<Student> _students;

    public StudentStore()
    {
        _students = new List<Student>();
    }

    public void Add(Student student)
    {
        _students.Add(student);
    }

    public Student? GetById(int id)
    {

        foreach (var student in _students)
        {
            if (id == student.Id)
                return student;
        }
        return null;
    }

    public List<Student> GetAll()
    {
        return _students;
    }

    public void Remove(int id)
    {
        var student = GetById(id);

        if (student != null)
            _students.Remove(student);
    }
}
