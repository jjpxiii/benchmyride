import 'dart:convert';
import 'dart:io';
import 'package:crypto/crypto.dart' as crypto;

Future<void> main(List<String> arguments) async {
  final jsonStr = await File('../../assets/10mil.json').readAsString();
  final data = jsonDecode(jsonStr);
  final array = List.from(data);
  array.sort();
  print(array[666]);
  print(array[666666]);
}
