public void HideRandomWords(int numberToHide)
{
    Random random = new Random();
    int wordsHidden = 0;

    // The !IsCompletelyHidden() check prevents an infinite loop 
    // when there are fewer unhidden words left than numberToHide.
    while (wordsHidden < numberToHide && !IsCompletelyHidden())
    {
        int index = random.Next(_words.Count);
        
        // Only hide and count it if it is currently visible
        if (!_words[index].IsHidden())
        {
            _words[index].Hide();
            wordsHidden++;
        }
    }
}