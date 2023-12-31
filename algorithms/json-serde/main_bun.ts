function printHash(data) {
  const str = JSON.stringify(data);
  const hasher = new Bun.CryptoHasher("md5");
  const hash = hasher.update(str).digest("hex");
  console.log(hash);
}

async function main() {
  const fileName = "canada";
  const jsonStr = await Bun.file(`${fileName}.json`).text();
  printHash(JSON.parse(jsonStr));
  const array = [];
  for (let i = 0; i < 13; i++) {
    array.push(JSON.parse(jsonStr));
  }
  printHash(array);
  printHash(JSON.stringify(array));
}

main();
