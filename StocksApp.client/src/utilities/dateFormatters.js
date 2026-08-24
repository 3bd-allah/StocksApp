
export function formatDateOnly(incomingString) {
    const date = new Date(incomingString);
    if (isNaN(date.getTime())) return "Invalid Date";
    const formattedDate = new Intl.DateTimeFormat('en-CA').format(date);
    return formattedDate
}


// convert '2026-11-28T03:12:30.8176741'  to  '28 NOVEMBER 2026 03:12:30 AM'
export function stockDateFormatter( inputDate ){
    const date = new Date(inputDate);
    const formatter = new Intl.DateTimeFormat("en-GB",{
        day: '2-digit',
        month:'long',
        year:'numeric',
        hour: '2-digit',
        minute:'2-digit',
        second:'2-digit',
        hour12: true
    });

    return formatter.format(date).toUpperCase();
}
