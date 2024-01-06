async function main() {
  const jsonStr = await Deno.readTextFile(`10mil.json`);
  const array = new Int32Array(JSON.parse(jsonStr)).sort();
  console.log(array[666]);
  console.log(array[666666]);
}

main();
