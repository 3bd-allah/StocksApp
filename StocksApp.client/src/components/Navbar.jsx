import { Link } from "react-router";
import { Toaster } from "react-hot-toast";
const NAVLINKS = [
  { name: "Persons", path: "/persons" },
  { name: "Company", path: "/company" },
  { name: "Upload Countries", path: "/country" },
];

const Navbar = () => {
  return (
    <>
      <nav className="flex items-center justify-between px-6 h-16 bg-slate-900 border-b border-slate-800 text-slate-200 sticky top-0 z-50">
        <Toaster />
        <div className="flex items-center gap-8">
          {/* Brand */}
          <Link
            to="/"
            className="font-bold text-xl tracking-tight  bg-clip-text bg-gradient-to-r from-emerald-400 to-teal-500"
          >
            StocksApp
          </Link>

          {/* Dynamic Links (Scalable & Infinite) */}
          <div className="flex items-center gap-1 sm:gap-2">
            {NAVLINKS.map((link) => (
              <Link
                key={link.path}
                to={link.path}
                className="text-slate-300 hover:text-emerald-400 text-sm font-medium transition-colors px-3 py-1.5 rounded-md hover:bg-slate-800/60"
              >
                {link.name}
              </Link>
            ))}
          </div>
        </div>

        {/* Action Button */}
        <button
          className="bg-emerald-500 hover:bg-emerald-600 text-slate-950 text-xs sm:text-sm font-semibold px-4 py-2 rounded-lg transition-colors"
          onClick={() => confirm("Trade functionality coming soon!")}
        >
          Trade Now
        </button>
      </nav>
    </>
  );
};

export default Navbar;
