class Resume {
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void Display() {
        Console.WriteLine($"Resume for {_name}");
        Console.WriteLine("Employment History:");
        foreach (Job job in _jobs) {
            job.Display();
        }
    }
}