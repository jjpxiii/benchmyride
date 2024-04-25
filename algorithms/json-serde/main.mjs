import { createHash } from "node:crypto";
import { readFileSync } from "node:fs";

function printHash(data) {
  const str = JSON.stringify(data);
  const hasher = createHash("md5");
  const hash = hasher.update(str);
  console.log(hash.digest("hex"));
}

async function main() {
  const jsonStr = await readFileSync(`canada.json`, "utf8");
  printHash(JSON.parse(jsonStr));
  const array = [];
  for (let i = 0; i < 13; i++) {
    array.push(JSON.parse(jsonStr));
  }
  printHash(array);
}

main();
