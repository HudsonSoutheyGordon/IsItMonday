import confetti from 'canvas-confetti'

const duration = 5 * 1000
const animationEnd = Date.now() + duration
const defaults = {
  startVelocity: 30,
  spread: 360,
  ticks: 60,
  zIndex: 0,
}

const randrange = (min, max) => {
  return Math.random() * (max - min) + min
}

const confett () => {
  const interval = setInterval(() => {
    const timeLeft = animationEnd - Date.now()

    if (timeLeft <= 0) {
      return clearInterval(interval)
    }

    const particleCount = 50 * (timeLeft / duration)
    // since particles fall down, start a bit higher than random
    confetti(
      Object.assign({}, defaults, {
        particleCount,
        origin: { x: randrange(0.1, 0.3), y: Math.random() - 0.2 },
      })
    )
    confetti(
      Object.assign({}, defaults, {
        particleCount,
        origin: { x: randrange(0.7, 0.9), y: Math.random() - 0.2 },
      })
    )
  }, 250)
}

export default confett
