import 'dart:io';

main(List<String> arguments) {

  new File("../../assets/regexin.txt")
    .readAsString()
    .then((String data) {
      // Email
      measure(data, r"[\w.+-]+@[\w.-]+\.[\w.-]+");

      // URI
      measure(data, r"[\w]+:\/\/[^\/\s?#]+[^\s?#]+(?:\?[^\s#]*)?(?:#[^\s]*)?");

      // IP
      measure(data, r"(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9])\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9])");
    });
}

measure(data, pattern){
  RegExp exp = new RegExp(pattern);
  Iterable<Match> matches = exp.allMatches(data);
  var count = matches.length;

  print('${count}');
}