import { readFileSync } from "node:fs";

async function main() {
  const jsonStr = await readFileSync(`10mil.json`, "utf8");
  const array = new Int32Array(JSON.parse(jsonStr)).sort();
  console.log(array[666]);
  console.log(array[666666]);
}

main();
