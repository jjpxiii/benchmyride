import sys
import re

def measure(data, pattern):
    regex = re.compile(pattern)
    matches = re.findall(regex, data)

    print(str(len(matches)))

with open(r"../../assets/regexin.txt", encoding="utf8") as file:
    data = file.read()

    # Email
    measure(data, r'[\w\.+-]+@[\w\.-]+\.[\w\.-]+')

    # URI
    measure(data, r'[\w]+://[^/\s?#]+[^\s?#]+(?:\?[^\s#]*)?(?:#[^\s]*)?')

    # IP
    measure(data, r'(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9])\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9])')