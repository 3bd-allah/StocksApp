export default function ErrorBlock({ title, message, errors }) {
 
  return (
    <div className="flex items-start gap-4 p-4 mb-4 bg-red-50 border border-red-200 rounded-xl shadow-sm max-w-xl">
      <div className="flex items-center justify-center shrink-0 w-8 h-8 rounded-full bg-red-100 text-red-600 font-bold text-lg select-none">
        !
      </div>
      <div className="space-y-1">
        <h2 className="text-sm font-semibold text-red-800 tracking-wide uppercase">
          {title || "An error occurred"}
        </h2>
        {errors ? (
          <ul className="text-sm text-red-700 leading-relaxed">
            {errors?.map((err) => (
              <li key={err}>- {err}</li>
            ))}
          </ul>
        ) : (
          <p className="text-sm text-red-700 leading-relaxed">
            {message || "Something went wrong. Please try again."}
          </p>
        )}
      </div>
    </div>
  );
}
