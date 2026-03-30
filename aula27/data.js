const dateFormatter = new Intl.DateTimeFormat("pt-BR", {
  weekday: 'long',
  day: '2-digit',
  month: 'long',
  year: 'numeric',
})
function formatTime(date) {
  const time = date.toLocaleTimeString('pt-BR', { hour12: false });
  const ms = String(date.getMilliseconds()).padStart(3, '0');
  return `${time}.${ms}`;
}