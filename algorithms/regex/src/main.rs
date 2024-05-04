use regex::bytes::RegexBuilder;

fn measure(data: &str, pattern: &str) {
    let regex = RegexBuilder::new(pattern).build().unwrap();
    let count = regex.find_iter(data.as_bytes()).count();

    println!("{}", count);
}

fn main() -> Result<(), Box<dyn std::error::Error + Send + Sync>> {
    let data = std::fs::read_to_string("../../assets/regexin.txt")?;

    // Email
    measure(&data, r"[\w\.+-]+@[\w\.-]+\.[\w\.-]+");

    // URI
    measure(&data, r"[\w]+://[^/\s?#]+[^\s?#]+(?:\?[^\s#]*)?(?:#[^\s]*)?");

    // IP
    measure(&data, r"(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9])\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9])");

    Ok(())
}