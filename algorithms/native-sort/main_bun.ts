async function main() {
  const jsonStr = await Bun.file(`../../assets/10mil.json`).text();
  const array = new Int32Array(JSON.parse(jsonStr)).sort();
  console.log(array[666]);
  console.log(array[666666]);
}

main();
