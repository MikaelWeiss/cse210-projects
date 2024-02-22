using Microsoft.VisualBasic;

class Assignment {
    private string studentName;
    protected string GetStudentName() {
        return studentName;
    }
    private string topic;

    public string GetSummary() {
        return $"{studentName} - {topic}";
    }

    public Assignment(string studentName, string topic) {
        this.studentName = studentName;
        this.topic = topic;
    }
}