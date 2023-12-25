def decode(message_file):
    # Initialize an empty dictionary to store the encoded words
    encoded_words = {}
 
    # Open and read the message file
    with open(message_file, 'r') as file:
        lines = file.readlines()
 
        # Parse each line in the file and store encoded words in the dictionary
        for line in lines:
            parts = line.strip().split()
            if len(parts) == 2:
                number, word = int(parts[0]), parts[1]
                encoded_words[number] = word
 
    # Sort the dictionary keys in ascending order
    sorted_keys = sorted(encoded_words.keys())
 
    # Create a list of decoded words in order
    decoded_words = [encoded_words[key] for key in sorted_keys]
 
    # Join the decoded words into a single string and return it
    decoded_message = ' '.join(decoded_words)
    return decoded_message
 
# Example usage:
message_file = "coding_qual_input.txt"  # Replace with the path to your .txt file
decoded_message = decode(message_file)
print(decoded_message)