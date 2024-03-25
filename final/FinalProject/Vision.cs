class Vision {
    private List<Goal> goals;
    private string description;
    void AddGoal(Goal goal) {
        goals.Add(goal);
    }
    void RemoveGoal(Goal goal) {
        goals.Remove(goal);
    }

    public Vision(string description) {
        this.description = description;
        goals = new List<Goal>();
    }
}