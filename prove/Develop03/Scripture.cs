public class Scripture 
{
    private List<Word> words;
    private Reference reference;
    public void HideThreeWords()
    {
        if (AllWordsAreHidden()) {
            return;
        }

        List<int> unhiddenIndices = FindUnhiddenWordIndecies();
        Random random = new Random();
        for (int i = 0; i < 3; i++) {
            int index = random.Next(unhiddenIndices.Count);
            int wordIndex = unhiddenIndices[index];
            words[wordIndex].Hide();
        }
    }

    private List<int> FindUnhiddenWordIndecies()
    {
        List<int> unhiddenIndices = new List<int>();
        foreach (Word word in words) {
            if (!word.IsHidden()) {
                unhiddenIndices.Add(words.IndexOf(word));
            }
        }
        return unhiddenIndices;
    }
    public string StringValue()
    {
        string result = reference.StringValue() + "\n";
        foreach (Word word in words) {
            result += word.StringValue() + " ";
        }
        return result;
    }
    public bool AllWordsAreHidden()
    {
        return !words.Exists(word => !word.IsHidden());
    }
    public Scripture(string book, string chapter, string verses, List<String> words)
    {
        this.reference = new Reference(book, chapter, verses);
        this.words = new List<Word>();
        foreach (string word in words) {
            this.words.Add(new Word(word));
        }
    }
}