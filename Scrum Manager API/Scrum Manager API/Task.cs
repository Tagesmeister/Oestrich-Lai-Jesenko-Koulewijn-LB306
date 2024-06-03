namespace Scrum_Manager_API;

public class Task
{
    private int _taskID;
    private string _title;
    private string _description;
    private string _status;
    private int _assigneeID;
    private bool _currentState;
    private int _sprintID;

    public int TaskID
    {
        get { return _taskID; }
        set { _taskID = value; }
    }

    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }

    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }

    public string Status
    {
        get { return _status; }
        set { _status = value; }
    }

    public int AssigneeID
    {
        get { return _assigneeID; }
        set { _assigneeID = value; }
    }

    public bool CurrentState
    {
        get { return _currentState; }
        set { _currentState = value; }
    }

    public int SprintID
    {
        get { return _sprintID; }
        set { _sprintID = value; }
    }

    public void ChangeState()
    {
        // Logic to change the state of the task
    }
}