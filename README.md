# Build

Build stuff : zig build-exe .\main2.zig -O ReleaseFast -fstrip -fsingle-threaded

go build -ldflags -s .\main.go

rustc -O main.rs

# Run

Try this : hyperfine '.\target\release\json-serde.exe canada' 'deno run -A main.ts canada' 'python main.py canada'

that : hyperfine 'main.exe' 'go run main.go' 'node main.js' 'deno run main.ts' 'main2.exe'

 hyperfine 'node main.js' 'deno run main.js' 'deno run main.ts' 'bun run main.js' 'bun run main.ts'


 goooo
