import json
import random

# Generate a list of a million random integers
integer_list = [random.randint(1, 100000000) for _ in range(10000000)]

# Save the list to a JSON file
with open('million_integers.json', 'w') as file:
    json.dump(integer_list, file)