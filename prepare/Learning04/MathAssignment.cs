using System;

public class MathAssignment : Assignment
{
    private string homework;

    public MathAssignment(string studentName, string topic, string dueDate, string homework) : base(studentName, topic)
    {
        this.homework = homework;
    }

    public string GetHomeworkList()
    {
        return this.homework;
    }
}
