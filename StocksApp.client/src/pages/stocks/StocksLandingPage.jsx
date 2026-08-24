
const StocksLandingPage = () => {
 return (
    <div className="w-full bg-gray-900 text-white font-sans border-b border-gray-800">
      {/* Hero Banner Container */}
      <section className="max-w-7xl mx-auto px-6 py-16 md:py-24 flex flex-col items-center text-center">
        {/* Subtle Badge */}
        <div className="inline-flex items-center gap-2 px-3 py-1 rounded-full bg-blue-950/80 border border-blue-800/50 text-blue-400 text-xs font-semibold mb-6">
          <span className="w-2 h-2 rounded-full bg-blue-400 animate-pulse" />
          Real-Time Equity & Market Analytics
        </div>

        {/* Main Heading */}
        <h1 className="text-4xl sm:text-5xl md:text-6xl font-extrabold tracking-tight max-w-3xl leading-tight mb-6">
          Track, Analyze, and Execute <br />
          <span className="bg-gradient-to-r from-blue-400 to-indigo-400 bg-clip-text text-transparent">
            With Pure Confidence
          </span>
        </h1>

        {/* Subtitle */}
        <p className="text-gray-400 text-base sm:text-lg max-w-2xl mb-10 leading-relaxed">
          Get real-time market overviews, monitor equity profiles, and seamlessly navigate through your trading portfolio with speed and precision.
        </p>

        {/* Key Metrics Row */}
        <div className="w-full max-w-4xl grid grid-cols-2 md:grid-cols-4 gap-4 pt-8 border-t border-gray-800">
          <div className="p-4 bg-gray-800/40 rounded-lg border border-gray-800">
            <div className="text-2xl font-bold text-white">10,000+</div>
            <div className="text-xs text-gray-400 mt-1">Tracked Equities</div>
          </div>
          <div className="p-4 bg-gray-800/40 rounded-lg border border-gray-800">
            <div className="text-2xl font-bold text-emerald-400">99.9%</div>
            <div className="text-xs text-gray-400 mt-1">Uptime SLA</div>
          </div>
          <div className="p-4 bg-gray-800/40 rounded-lg border border-gray-800">
            <div className="text-2xl font-bold text-blue-400">&lt; 10ms</div>
            <div className="text-xs text-gray-400 mt-1">Execution Speed</div>
          </div>
          <div className="p-4 bg-gray-800/40 rounded-lg border border-gray-800">
            <div className="text-2xl font-bold text-white">24/7</div>
            <div className="text-xs text-gray-400 mt-1">Live Data Stream</div>
          </div>
        </div>
      </section>

      {/* Feature Highlights Grid */}
      <section className="bg-gray-950 py-12 border-t border-gray-800/60">
        <div className="max-w-7xl mx-auto px-6 grid grid-cols-1 md:grid-cols-3 gap-6">
          <div className="p-6 rounded-lg bg-gray-900 border border-gray-800">
            <div className="text-blue-400 text-xl font-bold mb-2">⚡ Lightning Fast</div>
            <p className="text-sm text-gray-400 leading-relaxed">
              Instantaneous updates across equities, indexes, and market orders without page refreshes.
            </p>
          </div>

          <div className="p-6 rounded-lg bg-gray-900 border border-gray-800">
            <div className="text-blue-400 text-xl font-bold mb-2">📊 Deep Analytics</div>
            <p className="text-sm text-gray-400 leading-relaxed">
              Detailed company exchanges, pricing statistics, and industry classification breakdowns.
            </p>
          </div>

          <div className="p-6 rounded-lg bg-gray-900 border border-gray-800">
            <div className="text-blue-400 text-xl font-bold mb-2">🔒 Secure Trading</div>
            <p className="text-sm text-gray-400 leading-relaxed">
              Enterprise-grade data encryption ensuring safe and reliable order execution workflows.
            </p>
          </div>
        </div>
      </section>
    </div>
  );
}

export default StocksLandingPage