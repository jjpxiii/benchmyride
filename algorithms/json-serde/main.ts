import { Hash, encode } from "https://deno.land/x/checksum/mod.ts";

function printHash(data: any) {
    const str = JSON.stringify(data);
    const hasher = new Hash('md5');
    const hash = hasher.digestString(str).hex();
    console.log(hash);
}

async function main() {
    const fileName = Deno.args[0];
    const n = +Deno.args[1] || 3;
    const jsonStr = await Deno.readTextFile(`${fileName}.json`);
    printHash(JSON.parse(jsonStr));
    const array = [];
    for (let i = 0; i < n; i++) {
        array.push(JSON.parse(jsonStr));
    }
    printHash(array);
    printHash(JSON.stringify(array));
    
}

main();