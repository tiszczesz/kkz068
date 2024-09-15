const Calc = () => {
  return (
    <form>
      <div className="row m-2">
        <input className="col-6" type="number" />
        <span className="col-3 error"></span>
      </div>
      <div className="row m-2">
        <input className="col-6" type="number" />
        <span className="col-3 error"></span>
      </div>
      <div className="row m-2">
        <select className="offset-3 col-3">
          <option value="+">+</option>
          <option value="-">-</option>
          <option value="*">*</option>
          <option value="/">/</option>
        </select>
      </div>
      <div className="row m-2">
        <input className="col-6 btn btn-primary" type="submit" value="Oblicz" />
      </div>
    </form>
  );
};

export default Calc;
