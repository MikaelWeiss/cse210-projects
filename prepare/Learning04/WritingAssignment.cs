using System.Reflection.Metadata.Ecma335;

class WritingAssignment : Assignment {
    private string title;

    public string GetWritingInformation() {
        return $"{title} by {GetStudentName()}";
    }

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic) {
        this.title = title;
    }
}