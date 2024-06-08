import { Movie } from '../data/movies';

type Props = {
  list: Movie[];
  onDelete: (id: number) => void;
};

const MoviesList = (props: Props) => {
  console.log(props.list);

  return (
    <>
      <h2>Lista filmów</h2>
      <table className="table table-striped">
        <thead>
          <tr>
            <th>Lp</th>
            <th>Tytuł</th>
            <th>Reżyser</th>
            <th>Rok produkcji</th>
            <th>Cena</th>
            <th>Operacje</th>
          </tr>
        </thead>
        <tbody>
          {props.list.map((m, i) => (
            <tr key={m.id}>
              <td>{i + 1}</td>
              <td>{m.title}</td>
              <td>{m.director}</td>
              <td>{m.date}</td>
              <td style={{textAlign:'right'}}>{m.price}</td>
              <td >
                <input type="button" value="Usuń" className='btn btn-danger'
                    onClick={()=>props.onDelete(m.id)}
                />
              </td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
};

export default MoviesList;
