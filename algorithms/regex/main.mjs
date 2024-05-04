import fs from "node:fs";

function measure(data, pattern) {
  const regex = new RegExp(pattern, "g");
  const matches = data.match(regex);
  const count = matches.length;

  console.log(count);
}

const data = fs.readFileSync("../../assets/regexin.txt", "utf8");

// Email
measure(data, "[\\w.+-]+@[\\w.-]+\\.[\\w.-]+");

// URI
measure(
  data,
  "[\\w]+:\\/\\/[^\\/\\s?#]+[^\\s?#]+(?:\\?[^\\s#]*)?(?:#[^\\s]*)?"
);

// IP
measure(
  data,
  "(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9])\\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9])"
);
