using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Mothim : Pokemon
{
	public override string Name => "Mothim";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Swarm() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Tintedlens() };
	public override Stats BaseStats => new Stats(70, 94, 50, 94, 50, 66);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Quiverdance() },
		[1] = new List<Move>() { new Moves.Quiverdance(), new Moves.Tackle(), new Moves.Protect(), new Moves.Bugbite() },
		[10] = new List<Move>() { new Moves.Protect() },
		[15] = new List<Move>() { new Moves.Bugbite() },
		[20] = new List<Move>() { new Moves.Stringshot() },
		[23] = new List<Move>() { new Moves.Confusion() },
		[26] = new List<Move>() { new Moves.Gust() },
		[29] = new List<Move>() { new Moves.Poisonpowder() },
		[32] = new List<Move>() { new Moves.Psybeam() },
		[35] = new List<Move>() { new Moves.Roost() },
		[38] = new List<Move>() { new Moves.Strugglebug() },
		[41] = new List<Move>() { new Moves.Airslash() },
		[44] = new List<Move>() { new Moves.Psychic() },
		[47] = new List<Move>() { new Moves.Lunge() },
		[50] = new List<Move>() { new Moves.Bugbuzz() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Aerialace(), new Moves.Attract(), new Moves.Bugbite(), new Moves.Bugbuzz(), new Moves.Confide(), new Moves.Defog(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Electroweb(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Flash(), new Moves.Frustration(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Infestation(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Roost(), new Moves.Round(), new Moves.Safeguard(), new Moves.Shadowball(), new Moves.Signalbeam(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Strugglebug(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Tailwind(), new Moves.Thief(), new Moves.Uturn(), new Moves.Venoshock() };
	public override int Weight => 233;
	public override int ExpYield => 148;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 1,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 1,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}