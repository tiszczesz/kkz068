import { ReactNode, useState } from 'react';

type Props = {
  colors: string[];
  text?: string;
  children?: ReactNode;
};

const Color2Comp = (props: Props) => {
  const [color, setColor] = useState(props.colors[0]);
  return (
    <>
      <select value={color} onChange={(e) => setColor(e.target.value)}>
        {props.colors.map((color, index) => (
          <option key={index} value={color}>
            {color}
          </option>
        ))}
      </select>
      <div
        style={{
          minWidth: '100px',
          minHeight: '100px',
          textAlign: 'center',
          border: 'solid black 1px',
          backgroundColor: color,
        }}
      >
        {props.text}
      </div>
      {props.children && <div style={{ color: 'green' }}>{props.children}</div>}
    </>
  );
};

export default Color2Comp;
