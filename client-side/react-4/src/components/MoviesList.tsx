import { Movie } from "../data/movies";

type Props = {
  list: Movie[];
};

const MoviesList = (props: Props) => {
    console.log(props.list);
    
  return <h2>Lista filmów</h2>;
};

export default MoviesList;
