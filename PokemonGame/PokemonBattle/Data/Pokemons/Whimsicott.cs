using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Whimsicott : Pokemon
{
	public override string Name => "Whimsicott";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Prankster(), new Abilities.Infiltrator() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Chlorophyll() };
	public override Stats BaseStats => new Stats(60, 67, 85, 77, 75, 116);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Fairy };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Gust(), new Moves.Tailwind(), new Moves.Moonblast(), new Moves.Memento(), new Moves.Hurricane(), new Moves.Megadrain(), new Moves.Razorleaf(), new Moves.Growth(), new Moves.Poisonpowder(), new Moves.Gigadrain(), new Moves.Charm(), new Moves.Leechseed(), new Moves.Cottonspore(), new Moves.Energyball(), new Moves.Sunnyday(), new Moves.Endeavor(), new Moves.Cottonguard(), new Moves.Solarbeam(), new Moves.Absorb(), new Moves.Helpinghand(), new Moves.Fairywind(), new Moves.Stunspore() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Beatup(), new Moves.Charm(), new Moves.Dazzlinggleam(), new Moves.Encore(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Faketears(), new Moves.Fling(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Grassyglide(), new Moves.Grassyterrain(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hurricane(), new Moves.Hyperbeam(), new Moves.Lightscreen(), new Moves.Mistyterrain(), new Moves.Playrough(), new Moves.Protect(), new Moves.Psychic(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Seedbomb(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swift(), new Moves.Taunt(), new Moves.Thief(), new Moves.Trickroom(), new Moves.Uturn() };
	public override int Weight => 66;
	public override int ExpYield => 168;
	public override int CatchRate => 75;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 2
	};
}