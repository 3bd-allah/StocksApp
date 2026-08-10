
export function formatDateOnly(incomingString) {
    const date = new Date(incomingString);
    if (isNaN(date.getTime())) return "Invalid Date";
    const formattedDate = new Intl.DateTimeFormat('en-CA').format(date);
    return formattedDate
}


/**
 * Triggers a browser download for a Blob or raw binary data.
 * 
 * @param {Blob | ArrayBuffer} data - The binary file data to download.
 * @param {string} filename - The desired name for the downloaded file.
 * @param {string} [mimeType] - Optional MIME type override (e.g., 'application/pdf').
 */