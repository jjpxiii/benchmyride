use std::fs;

fn main() -> anyhow::Result<()> {
    let json_str = fs::read_to_string("10mil.json")?;
    let mut array: Vec<i32> = serde_json::from_str(&json_str)?;
    // let array = serde_json::json!(json);
    array.sort();
    println!("{}", array[666]);
    println!("{}", array[666666]);
    Ok(())
}
