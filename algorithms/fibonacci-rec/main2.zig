const print = @import("std").debug.print;

fn fibonacci(index: u32) u32 {
    if (index < 2) return index;
    return fibonacci(index - 1) + fibonacci(index - 2);
}

pub fn main() void {
    print("{}", .{fibonacci(42)});
}