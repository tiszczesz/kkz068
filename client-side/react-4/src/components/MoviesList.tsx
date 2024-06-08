import { Movie } from "../data/movies";

type Props = {
  list: Movie[];
};

const MoviesList = ({ list: movies }: Props) => {
  return <h2>Lista filmów</h2>;
};

export default MoviesList;
