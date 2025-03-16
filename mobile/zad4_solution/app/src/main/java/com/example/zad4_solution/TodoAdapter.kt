package com.example.zad4_solution



import android.content.Context
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.BaseAdapter
import android.widget.TextView

class TodoAdapter(private val context: Context, private val dataSource: List<Todo>) : BaseAdapter() {

    private val inflater: LayoutInflater = context.getSystemService(Context.LAYOUT_INFLATER_SERVICE) as LayoutInflater

    override fun getCount(): Int {
        return dataSource.size
    }

    override fun getItem(position: Int): Any {
        return dataSource[position]
    }

    override fun getItemId(position: Int): Long {
        return position.toLong()
    }

    override fun getView(position: Int, convertView: View?, parent: ViewGroup): View {
        val rowView = convertView ?: inflater.inflate(R.layout.list_todos, parent, false)

        val titleTextView = rowView.findViewById<TextView>(R.id.textView)
        val contentTextView = rowView.findViewById<TextView>(R.id.textView2)

        val todo = getItem(position) as Todo
        titleTextView.text = todo.title
        contentTextView.text = todo.Content

        return rowView
    }
}