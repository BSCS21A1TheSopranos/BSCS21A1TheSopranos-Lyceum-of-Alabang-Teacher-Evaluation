import sys
from textblob import TextBlob
from langdetect import detect
from deep_translator import GoogleTranslator
import re
from spellchecker import SpellChecker
import emoji
import nltk

# Download punkt tokenizer for sentence splitting
nltk.download('punkt')

# Function Definitions

def correct_elongated_words(text):
    """Reduce elongated words (e.g., "soooo" -> "soo")."""
    return re.sub(r'(.)\1{2,}', r'\1\1', text)

def correct_typos(text):
    """Correct typos in the text."""
    spell = SpellChecker()
    words = text.split()
    corrected_words = [spell.correction(word) if spell.correction(word) is not None else word for word in words]
    return " ".join(corrected_words)

def preprocess_slang(text):
    """Replace slang and informal terms with their meanings."""
    slang_dict = {
        "char": "just kidding",
        "luv": "love",
        "corny": "not funny"
    }
    words = text.split()
    return " ".join([slang_dict.get(word.lower(), word) for word in words])

def replace_emojis(text):
    """Replace emojis with their textual meanings."""
    emoji_dict = {
        "😊": "happy",
        "😡": "angry",
        "❤️": "love",
        "💔": "heartbroken",
        "😂": "laughing",
        "😢": "sad"
    }
    return emoji.replace_emoji(text, replace=lambda e, _: emoji_dict.get(e, e))

def analyze_sentence_sentiment(text):
    """Analyze sentiment for each sentence and return overall sentiment."""
    sentences = nltk.sent_tokenize(text)
    sentiment_scores = []

    for sentence in sentences:
        blob = TextBlob(sentence)
        sentiment_scores.append(blob.sentiment.polarity)

    # Aggregate sentiment: Use weighted average or most dominant sentiment
    overall_sentiment_score = sum(sentiment_scores) / len(sentiment_scores)

    if overall_sentiment_score > 0:
        return "Positive"
    else:
        return "Negative"

def translate_and_analyze(text):
    """Detect language, preprocess text, translate if necessary, and analyze sentiment."""
    # Detect language
    language = detect(text)

    # Correct elongated words
    text = correct_elongated_words(text)

    # Preprocess slang
    text = preprocess_slang(text)

    # Replace emojis
    text = replace_emojis(text)

    # Translate if not in English
    if language != 'en':
        text = GoogleTranslator(source='auto', target='en').translate(text)

    # Analyze sentence-level sentiment
    sentiment = analyze_sentence_sentiment(text)
    return sentiment

# Main execution block
if __name__ == "__main__":
    # Get the text from command-line arguments
    if len(sys.argv) > 1:
        input_text = sys.argv[1]  # The text passed from WinForms
        sentiment = translate_and_analyze(input_text)  # Call the function
        print(sentiment)  # Output the sentiment result (sentiment only)
    else:
        print("No input text provided.")
