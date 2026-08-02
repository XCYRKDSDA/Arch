namespace Arch.Core.Events;

/// <summary>
///     A delegate called once a new <see cref="Entity"/> was created.
/// </summary>
public delegate void EntityCreatedHandler(in Entity entity);

/// <summary>
///     A delegate called once a <see cref="Entity"/> was destroyed.
/// </summary>
public delegate void EntityDestroyedHandler(in Entity entity);

/// <summary>
///     A delegate called once a componnet was added for a specific <see cref="Entity"/>.
/// <typeparam name="T">The generic component.</typeparam>
/// </summary>
public delegate void ComponentAddedHandler<T>(in Entity entity, ref T comp);

/// <summary>
///     A delegate called once a component was set for a specific <see cref="Entity"/>.
/// </summary>
/// <param name="oldValue">The old component value.</param>
/// <param name="newValue">The new component value.</param>
/// <typeparam name="T">The generic component.</typeparam>
public delegate void ComponentSetHandler<T>(in Entity entity, in T oldValue, ref T newValue);

/// <summary>
///     A delegate called once a component was removed from a specific <see cref="Entity"/>.
/// <typeparam name="T">The generic component.</typeparam>
/// </summary>
public delegate void ComponentRemovedHandler<T>(in Entity entity, ref T comp);

/// <summary>
///     A delegate called once a componnet was added for a specific <see cref="Entity"/>.
/// </summary>
public delegate void ComponentAddedHandler(in Entity entity);

/// <summary>
///     A delegate called once a component was set for a specific <see cref="Entity"/>.
/// </summary>
/// <param name="oldValue">The old component value.</param>
public delegate void ComponentSetHandler(in Entity entity, object oldValue);

/// <summary>
///     A delegate called once a component was set for a specific <see cref="Entity"/>.
/// </summary>
public delegate void ComponentRemovedHandler(in Entity entity);


