import codecs
import json


def main():
    with codecs.open('../../assets/10mil.json', 'r', 'utf-8-sig') as fp:
        json_str = fp.read()
    array = json.loads(json_str)
    array.sort()
    print(array[666])
    print(array[666666])


if __name__ == '__main__':
    main()