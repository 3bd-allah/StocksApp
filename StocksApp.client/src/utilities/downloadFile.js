/**
 * Triggers a browser download for a Blob or raw binary data.
 * 
 * @param {Blob | ArrayBuffer} data - The binary file data to download.
 * @param {string} filename - The desired name for the downloaded file.
 * @param {string} [mimeType] - Optional MIME type override (e.g., 'application/pdf').
 */
export const downloadFile = (data, filename = 'download', mimeType) => {
  if (!data) {
    console.error('downloadFile: No data provided for download.');
    return;
  }

  // Ensure data is converted to a Blob with the specified MIME type if provided
  const blob = data instanceof Blob 
    ? (mimeType ? new Blob([data], { type: mimeType }) : data)
    : new Blob([data], { type: mimeType || 'application/octet-stream' });

  // Generate a temporary URL for the Blob
  const url = window.URL.createObjectURL(blob);
  const link = document.createElement('a');

  link.href = url;
  link.setAttribute('download', filename);

  // Append, click, and clean up
  document.body.appendChild(link);
  link.click();

  // Cleanup DOM element and memory
  link.remove();
  window.URL.revokeObjectURL(url);
};