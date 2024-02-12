public class Word 
{
    private string value;
    private bool hidden;
    public string StringValue()
    {
        if (hidden) {
            string hiddenValue = "";
            for (int i = 0; i < value.Length; i++){
                hiddenValue += "_";
            }
            return hiddenValue;
        } else {
            return value;
        }
    }
    public void Hide()
    {
        hidden = true;
    }
    public bool IsHidden()
    {
        return hidden;
    }
    public Word(string value)
    {
        this.value = value;
        this.hidden = false;
    }
}